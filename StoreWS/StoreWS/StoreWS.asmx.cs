using StoreWS.Service;
using System.Web.Services;

namespace StoreWS
{
    /// <summary>
    /// Descrição resumida de StoreWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class StoreWS : System.Web.Services.WebService
    {
        private readonly IClientService _clientService;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public StoreWS(IClientService clientService,
            IOrderService orderService,
            IProductService productService)
        {
            _clientService = clientService;
            _orderService = orderService;
            _productService = productService;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }
    }
}
