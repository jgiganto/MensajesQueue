using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.WindowsAzure.Storage.Blob;
using static System.Collections.Specialized.BitVector32;

namespace MensajesQueue
{
    public partial class Form1 : Form
    {
        public CloudQueue GetColaMensajes(String nombrequeue)
        {
            String claves =
                CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount cuenta =
                CloudStorageAccount.Parse(claves);
            CloudQueueClient cliente =
                cuenta.CreateCloudQueueClient();
            CloudQueue cola = cliente.GetQueueReference(nombrequeue);
            cola.CreateIfNotExists();
            return cola;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncrearmensaje_Click(object sender, EventArgs e)
        {
            String nombrequeue = this.cmbusuarios.SelectedItem.ToString();
            CloudQueue cola = this.GetColaMensajes(nombrequeue);
            String contenido =
                DateTime.Now.ToShortDateString() +
                "" +
                DateTime.Now.ToLongTimeString() + "-" +
                this.txtmensaje.Text;
            CloudQueueMessage mensaje =
                new CloudQueueMessage(contenido);
            cola.AddMessage(mensaje);
            this.lblmensaje.Text = "Mensaje Creado";
        }

        private void btnultimomensaje_Click(object sender, EventArgs e)
        {
            this.lsvmensajes.Items.Clear();
            CloudQueue cola = this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            CloudQueueMessage mensaje = cola.PeekMessage();
            if (mensaje == null)
            {
                this.lblmensaje.Text = "No hay mensajes";
            }
            else
            {
                this.lsvmensajes.Items.Add(mensaje.AsString);
            }
        }

        private void btntodosmensajes_Click(object sender, EventArgs e)
        {
            this.lsvmensajes.Items.Clear();
            CloudQueue cola = this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            foreach(CloudQueueMessage mensaje in cola.GetMessages(32))
            {
                this.lsvmensajes.Items.Add(mensaje.AsString);//asstring devuelve el contenido ,no es lo mismo q tostring
            }
            
        }

        private void btnmodificarmensaje_Click(object sender, EventArgs e)
        {
            CloudQueue cola =
                this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            CloudQueueMessage mensaje = cola.GetMessage();
            mensaje.SetMessageContent(
                DateTime.Now.ToShortDateString() +
                ""
                + DateTime.Now.ToLongDateString()
                + this.txtmensaje.Text);
            cola.UpdateMessage(mensaje, TimeSpan.FromMinutes(5),
                MessageUpdateFields.Content | MessageUpdateFields.Visibility);
            this.lblmensaje.Text = "Mensaje modificado";
        }

        private void btnborrarmensaje_Click(object sender, EventArgs e)
        {
            CloudQueue cola =
                this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            CloudQueueMessage mensaje =
                cola.GetMessage();
            cola.DeleteMessage(mensaje);
            this.lblmensaje.Text = "Mensaje eliminado";

        }

        private void btnborrartareas_Click(object sender, EventArgs e)
        {
            CloudQueue cola =
          this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            IEnumerable<CloudQueueMessage> mensajes =
                cola.GetMessages(32);
            foreach(CloudQueueMessage msj in mensajes)
            {
                cola.DeleteMessage(msj);
            }
            this.lblmensaje.Text = "Cola de mensajes vacía";
        }

        private void btngenerartoken_Click(object sender, EventArgs e)
        {
           String token = this.GenerarToken("contenedorseguro");
           
            this.lblmensaje.Text = token;
        }

        public CloudBlobContainer RecuperarContenedor(String nombrecontainer)
        {
            String claves =
                CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount cuenta =
                CloudStorageAccount.Parse(claves);
            CloudBlobClient cliente = cuenta.CreateCloudBlobClient();
            CloudBlobContainer contenedor =
                cliente.GetContainerReference(nombrecontainer);
            contenedor.CreateIfNotExists();
            return contenedor;
        }
        public String GenerarToken(String nombreconteneor)
        {
            CloudBlobContainer contenedor = this.RecuperarContenedor(nombreconteneor);
            SharedAccessBlobPolicy permisos =
                new SharedAccessBlobPolicy();
            //tiempo de duracion y permisos
            permisos.SharedAccessExpiryTime = DateTime.Now.AddMinutes(5);
            permisos.Permissions = SharedAccessBlobPermissions.List
                | SharedAccessBlobPermissions.Create
                | SharedAccessBlobPermissions.Read
                | SharedAccessBlobPermissions.Delete;
            String token =
                contenedor.GetSharedAccessSignature(permisos);
            return contenedor.Uri + token;
        }

        private void btnmensajessas_Click(object sender, EventArgs e)
        {
            Uri url = new Uri(this.lblmensaje.Text);//token
            CloudBlobContainer contenedor =
               new CloudBlobContainer(url);
            CloudQueueClient

        }
    }
}
