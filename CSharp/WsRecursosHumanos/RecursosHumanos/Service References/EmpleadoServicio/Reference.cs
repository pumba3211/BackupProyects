﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18449
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecursosHumanos.EmpleadoServicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Empleado", Namespace="http://schemas.datacontract.org/2004/07/WsRecursosHumanos.Estructuras")]
    [System.SerializableAttribute()]
    public partial class Empleado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PuestoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cedula {
            get {
                return this.CedulaField;
            }
            set {
                if ((this.CedulaField.Equals(value) != true)) {
                    this.CedulaField = value;
                    this.RaisePropertyChanged("Cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Puesto {
            get {
                return this.PuestoField;
            }
            set {
                if ((object.ReferenceEquals(this.PuestoField, value) != true)) {
                    this.PuestoField = value;
                    this.RaisePropertyChanged("Puesto");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/WsRecursosHumanos.Estructuras")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Clave {
            get {
                return this.ClaveField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaveField, value) != true)) {
                    this.ClaveField = value;
                    this.RaisePropertyChanged("Clave");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpleadoServicio.IEmpleadoServicio")]
    public interface IEmpleadoServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/AgregarEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/AgregarEmpleadoResponse")]
        string AgregarEmpleado(RecursosHumanos.EmpleadoServicio.Empleado empleado, RecursosHumanos.EmpleadoServicio.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/AgregarEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/AgregarEmpleadoResponse")]
        System.Threading.Tasks.Task<string> AgregarEmpleadoAsync(RecursosHumanos.EmpleadoServicio.Empleado empleado, RecursosHumanos.EmpleadoServicio.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/EditarEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/EditarEmpleadoResponse")]
        string EditarEmpleado(RecursosHumanos.EmpleadoServicio.Empleado empleado, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/EditarEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/EditarEmpleadoResponse")]
        System.Threading.Tasks.Task<string> EditarEmpleadoAsync(RecursosHumanos.EmpleadoServicio.Empleado empleado, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/EliminarEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/EliminarEmpleadoResponse")]
        string EliminarEmpleado(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/EliminarEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/EliminarEmpleadoResponse")]
        System.Threading.Tasks.Task<string> EliminarEmpleadoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/TraerEmpleados", ReplyAction="http://tempuri.org/IEmpleadoServicio/TraerEmpleadosResponse")]
        RecursosHumanos.EmpleadoServicio.Empleado[] TraerEmpleados(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/TraerEmpleados", ReplyAction="http://tempuri.org/IEmpleadoServicio/TraerEmpleadosResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.EmpleadoServicio.Empleado[]> TraerEmpleadosAsync(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/ObtenerEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/ObtenerEmpleadoResponse")]
        RecursosHumanos.EmpleadoServicio.Empleado ObtenerEmpleado(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/ObtenerEmpleado", ReplyAction="http://tempuri.org/IEmpleadoServicio/ObtenerEmpleadoResponse")]
        System.Threading.Tasks.Task<RecursosHumanos.EmpleadoServicio.Empleado> ObtenerEmpleadoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/ObtenerTipoCambio", ReplyAction="http://tempuri.org/IEmpleadoServicio/ObtenerTipoCambioResponse")]
        double ObtenerTipoCambio();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleadoServicio/ObtenerTipoCambio", ReplyAction="http://tempuri.org/IEmpleadoServicio/ObtenerTipoCambioResponse")]
        System.Threading.Tasks.Task<double> ObtenerTipoCambioAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpleadoServicioChannel : RecursosHumanos.EmpleadoServicio.IEmpleadoServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpleadoServicioClient : System.ServiceModel.ClientBase<RecursosHumanos.EmpleadoServicio.IEmpleadoServicio>, RecursosHumanos.EmpleadoServicio.IEmpleadoServicio {
        
        public EmpleadoServicioClient() {
        }
        
        public EmpleadoServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpleadoServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadoServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadoServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AgregarEmpleado(RecursosHumanos.EmpleadoServicio.Empleado empleado, RecursosHumanos.EmpleadoServicio.Usuario usuario) {
            return base.Channel.AgregarEmpleado(empleado, usuario);
        }
        
        public System.Threading.Tasks.Task<string> AgregarEmpleadoAsync(RecursosHumanos.EmpleadoServicio.Empleado empleado, RecursosHumanos.EmpleadoServicio.Usuario usuario) {
            return base.Channel.AgregarEmpleadoAsync(empleado, usuario);
        }
        
        public string EditarEmpleado(RecursosHumanos.EmpleadoServicio.Empleado empleado, int id) {
            return base.Channel.EditarEmpleado(empleado, id);
        }
        
        public System.Threading.Tasks.Task<string> EditarEmpleadoAsync(RecursosHumanos.EmpleadoServicio.Empleado empleado, int id) {
            return base.Channel.EditarEmpleadoAsync(empleado, id);
        }
        
        public string EliminarEmpleado(int id) {
            return base.Channel.EliminarEmpleado(id);
        }
        
        public System.Threading.Tasks.Task<string> EliminarEmpleadoAsync(int id) {
            return base.Channel.EliminarEmpleadoAsync(id);
        }
        
        public RecursosHumanos.EmpleadoServicio.Empleado[] TraerEmpleados(string filtro) {
            return base.Channel.TraerEmpleados(filtro);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.EmpleadoServicio.Empleado[]> TraerEmpleadosAsync(string filtro) {
            return base.Channel.TraerEmpleadosAsync(filtro);
        }
        
        public RecursosHumanos.EmpleadoServicio.Empleado ObtenerEmpleado(int id) {
            return base.Channel.ObtenerEmpleado(id);
        }
        
        public System.Threading.Tasks.Task<RecursosHumanos.EmpleadoServicio.Empleado> ObtenerEmpleadoAsync(int id) {
            return base.Channel.ObtenerEmpleadoAsync(id);
        }
        
        public double ObtenerTipoCambio() {
            return base.Channel.ObtenerTipoCambio();
        }
        
        public System.Threading.Tasks.Task<double> ObtenerTipoCambioAsync() {
            return base.Channel.ObtenerTipoCambioAsync();
        }
    }
}
