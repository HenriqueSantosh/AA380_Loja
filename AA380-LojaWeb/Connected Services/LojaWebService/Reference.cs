﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_loja.LojaWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/Loja_Web_services.Entidade.Entidade")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Projeto_loja.LojaWebService.NotaFicalProduto[] ProdutosField;
        
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
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
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
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Preco {
            get {
                return this.PrecoField;
            }
            set {
                if ((this.PrecoField.Equals(value) != true)) {
                    this.PrecoField = value;
                    this.RaisePropertyChanged("Preco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Projeto_loja.LojaWebService.NotaFicalProduto[] Produtos {
            get {
                return this.ProdutosField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutosField, value) != true)) {
                    this.ProdutosField = value;
                    this.RaisePropertyChanged("Produtos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NotaFicalProduto", Namespace="http://schemas.datacontract.org/2004/07/Loja_Web_services.Entidade.Entidade")]
    [System.SerializableAttribute()]
    public partial class NotaFicalProduto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Projeto_loja.LojaWebService.NotaFiscal NotaFiscalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NotaFiscalIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Projeto_loja.LojaWebService.Produto ProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProdutoIdField;
        
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
        public Projeto_loja.LojaWebService.NotaFiscal NotaFiscal {
            get {
                return this.NotaFiscalField;
            }
            set {
                if ((object.ReferenceEquals(this.NotaFiscalField, value) != true)) {
                    this.NotaFiscalField = value;
                    this.RaisePropertyChanged("NotaFiscal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NotaFiscalId {
            get {
                return this.NotaFiscalIdField;
            }
            set {
                if ((this.NotaFiscalIdField.Equals(value) != true)) {
                    this.NotaFiscalIdField = value;
                    this.RaisePropertyChanged("NotaFiscalId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Projeto_loja.LojaWebService.Produto Produto {
            get {
                return this.ProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoField, value) != true)) {
                    this.ProdutoField = value;
                    this.RaisePropertyChanged("Produto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProdutoId {
            get {
                return this.ProdutoIdField;
            }
            set {
                if ((this.ProdutoIdField.Equals(value) != true)) {
                    this.ProdutoIdField = value;
                    this.RaisePropertyChanged("ProdutoId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NotaFiscal", Namespace="http://schemas.datacontract.org/2004/07/Loja_Web_services.Entidade.Entidade")]
    [System.SerializableAttribute()]
    public partial class NotaFiscal : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Projeto_loja.LojaWebService.NotaFicalProduto[] ProdutosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ValorTotalField;
        
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
        public System.DateTime DataNota {
            get {
                return this.DataNotaField;
            }
            set {
                if ((this.DataNotaField.Equals(value) != true)) {
                    this.DataNotaField = value;
                    this.RaisePropertyChanged("DataNota");
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
        public Projeto_loja.LojaWebService.NotaFicalProduto[] Produtos {
            get {
                return this.ProdutosField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutosField, value) != true)) {
                    this.ProdutosField = value;
                    this.RaisePropertyChanged("Produtos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float ValorTotal {
            get {
                return this.ValorTotalField;
            }
            set {
                if ((this.ValorTotalField.Equals(value) != true)) {
                    this.ValorTotalField = value;
                    this.RaisePropertyChanged("ValorTotal");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LojaWebService.IWebService")]
    public interface IWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/SaveOrUpdateProduto", ReplyAction="http://tempuri.org/IWebService/SaveOrUpdateProdutoResponse")]
        bool SaveOrUpdateProduto(Projeto_loja.LojaWebService.Produto product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/SaveOrUpdateProduto", ReplyAction="http://tempuri.org/IWebService/SaveOrUpdateProdutoResponse")]
        System.Threading.Tasks.Task<bool> SaveOrUpdateProdutoAsync(Projeto_loja.LojaWebService.Produto product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/SaveOrUpdateNota", ReplyAction="http://tempuri.org/IWebService/SaveOrUpdateNotaResponse")]
        bool SaveOrUpdateNota(Projeto_loja.LojaWebService.NotaFiscal nota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/SaveOrUpdateNota", ReplyAction="http://tempuri.org/IWebService/SaveOrUpdateNotaResponse")]
        System.Threading.Tasks.Task<bool> SaveOrUpdateNotaAsync(Projeto_loja.LojaWebService.NotaFiscal nota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/DeleteProduto", ReplyAction="http://tempuri.org/IWebService/DeleteProdutoResponse")]
        bool DeleteProduto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/DeleteProduto", ReplyAction="http://tempuri.org/IWebService/DeleteProdutoResponse")]
        System.Threading.Tasks.Task<bool> DeleteProdutoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/DeleteNota", ReplyAction="http://tempuri.org/IWebService/DeleteNotaResponse")]
        bool DeleteNota(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/DeleteNota", ReplyAction="http://tempuri.org/IWebService/DeleteNotaResponse")]
        System.Threading.Tasks.Task<bool> DeleteNotaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetProdutoByID", ReplyAction="http://tempuri.org/IWebService/GetProdutoByIDResponse")]
        Projeto_loja.LojaWebService.Produto GetProdutoByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetProdutoByID", ReplyAction="http://tempuri.org/IWebService/GetProdutoByIDResponse")]
        System.Threading.Tasks.Task<Projeto_loja.LojaWebService.Produto> GetProdutoByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetProdutoByNameDESc", ReplyAction="http://tempuri.org/IWebService/GetProdutoByNameDEScResponse")]
        Projeto_loja.LojaWebService.Produto[] GetProdutoByNameDESc(string nome, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetProdutoByNameDESc", ReplyAction="http://tempuri.org/IWebService/GetProdutoByNameDEScResponse")]
        System.Threading.Tasks.Task<Projeto_loja.LojaWebService.Produto[]> GetProdutoByNameDEScAsync(string nome, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetProdutos", ReplyAction="http://tempuri.org/IWebService/GetProdutosResponse")]
        Projeto_loja.LojaWebService.Produto[] GetProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetProdutos", ReplyAction="http://tempuri.org/IWebService/GetProdutosResponse")]
        System.Threading.Tasks.Task<Projeto_loja.LojaWebService.Produto[]> GetProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetNotas", ReplyAction="http://tempuri.org/IWebService/GetNotasResponse")]
        Projeto_loja.LojaWebService.NotaFiscal[] GetNotas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/GetNotas", ReplyAction="http://tempuri.org/IWebService/GetNotasResponse")]
        System.Threading.Tasks.Task<Projeto_loja.LojaWebService.NotaFiscal[]> GetNotasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/AddGridProduct", ReplyAction="http://tempuri.org/IWebService/AddGridProductResponse")]
        Projeto_loja.LojaWebService.NotaFiscal AddGridProduct(Projeto_loja.LojaWebService.Produto produto, Projeto_loja.LojaWebService.NotaFiscal notaFiscal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/AddGridProduct", ReplyAction="http://tempuri.org/IWebService/AddGridProductResponse")]
        System.Threading.Tasks.Task<Projeto_loja.LojaWebService.NotaFiscal> AddGridProductAsync(Projeto_loja.LojaWebService.Produto produto, Projeto_loja.LojaWebService.NotaFiscal notaFiscal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/RemoveProduct", ReplyAction="http://tempuri.org/IWebService/RemoveProductResponse")]
        Projeto_loja.LojaWebService.NotaFiscal RemoveProduct(int id, Projeto_loja.LojaWebService.NotaFiscal notaFiscal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/RemoveProduct", ReplyAction="http://tempuri.org/IWebService/RemoveProductResponse")]
        System.Threading.Tasks.Task<Projeto_loja.LojaWebService.NotaFiscal> RemoveProductAsync(int id, Projeto_loja.LojaWebService.NotaFiscal notaFiscal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/SumPrice", ReplyAction="http://tempuri.org/IWebService/SumPriceResponse")]
        double SumPrice(Projeto_loja.LojaWebService.NotaFiscal notaFiscal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebService/SumPrice", ReplyAction="http://tempuri.org/IWebService/SumPriceResponse")]
        System.Threading.Tasks.Task<double> SumPriceAsync(Projeto_loja.LojaWebService.NotaFiscal notaFiscal);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebServiceChannel : Projeto_loja.LojaWebService.IWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceClient : System.ServiceModel.ClientBase<Projeto_loja.LojaWebService.IWebService>, Projeto_loja.LojaWebService.IWebService {
        
        public WebServiceClient() {
        }
        
        public WebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SaveOrUpdateProduto(Projeto_loja.LojaWebService.Produto product) {
            return base.Channel.SaveOrUpdateProduto(product);
        }
        
        public System.Threading.Tasks.Task<bool> SaveOrUpdateProdutoAsync(Projeto_loja.LojaWebService.Produto product) {
            return base.Channel.SaveOrUpdateProdutoAsync(product);
        }
        
        public bool SaveOrUpdateNota(Projeto_loja.LojaWebService.NotaFiscal nota) {
            return base.Channel.SaveOrUpdateNota(nota);
        }
        
        public System.Threading.Tasks.Task<bool> SaveOrUpdateNotaAsync(Projeto_loja.LojaWebService.NotaFiscal nota) {
            return base.Channel.SaveOrUpdateNotaAsync(nota);
        }
        
        public bool DeleteProduto(int id) {
            return base.Channel.DeleteProduto(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProdutoAsync(int id) {
            return base.Channel.DeleteProdutoAsync(id);
        }
        
        public bool DeleteNota(int id) {
            return base.Channel.DeleteNota(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteNotaAsync(int id) {
            return base.Channel.DeleteNotaAsync(id);
        }
        
        public Projeto_loja.LojaWebService.Produto GetProdutoByID(int id) {
            return base.Channel.GetProdutoByID(id);
        }
        
        public System.Threading.Tasks.Task<Projeto_loja.LojaWebService.Produto> GetProdutoByIDAsync(int id) {
            return base.Channel.GetProdutoByIDAsync(id);
        }
        
        public Projeto_loja.LojaWebService.Produto[] GetProdutoByNameDESc(string nome, string descricao) {
            return base.Channel.GetProdutoByNameDESc(nome, descricao);
        }
        
        public System.Threading.Tasks.Task<Projeto_loja.LojaWebService.Produto[]> GetProdutoByNameDEScAsync(string nome, string descricao) {
            return base.Channel.GetProdutoByNameDEScAsync(nome, descricao);
        }
        
        public Projeto_loja.LojaWebService.Produto[] GetProdutos() {
            return base.Channel.GetProdutos();
        }
        
        public System.Threading.Tasks.Task<Projeto_loja.LojaWebService.Produto[]> GetProdutosAsync() {
            return base.Channel.GetProdutosAsync();
        }
        
        public Projeto_loja.LojaWebService.NotaFiscal[] GetNotas() {
            return base.Channel.GetNotas();
        }
        
        public System.Threading.Tasks.Task<Projeto_loja.LojaWebService.NotaFiscal[]> GetNotasAsync() {
            return base.Channel.GetNotasAsync();
        }
        
        public Projeto_loja.LojaWebService.NotaFiscal AddGridProduct(Projeto_loja.LojaWebService.Produto produto, Projeto_loja.LojaWebService.NotaFiscal notaFiscal) {
            return base.Channel.AddGridProduct(produto, notaFiscal);
        }
        
        public System.Threading.Tasks.Task<Projeto_loja.LojaWebService.NotaFiscal> AddGridProductAsync(Projeto_loja.LojaWebService.Produto produto, Projeto_loja.LojaWebService.NotaFiscal notaFiscal) {
            return base.Channel.AddGridProductAsync(produto, notaFiscal);
        }
        
        public Projeto_loja.LojaWebService.NotaFiscal RemoveProduct(int id, Projeto_loja.LojaWebService.NotaFiscal notaFiscal) {
            return base.Channel.RemoveProduct(id, notaFiscal);
        }
        
        public System.Threading.Tasks.Task<Projeto_loja.LojaWebService.NotaFiscal> RemoveProductAsync(int id, Projeto_loja.LojaWebService.NotaFiscal notaFiscal) {
            return base.Channel.RemoveProductAsync(id, notaFiscal);
        }
        
        public double SumPrice(Projeto_loja.LojaWebService.NotaFiscal notaFiscal) {
            return base.Channel.SumPrice(notaFiscal);
        }
        
        public System.Threading.Tasks.Task<double> SumPriceAsync(Projeto_loja.LojaWebService.NotaFiscal notaFiscal) {
            return base.Channel.SumPriceAsync(notaFiscal);
        }
    }
}