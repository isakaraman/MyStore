using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyStore.Views.Clients
{
    public class Create : PageModel
    {
        public ClientInfo ClientInfo = new ClientInfo();
        public string errorMessage = "";
		private string successMessage;

		public void OnGet()
        {
        }
        public void OnPost() 
        {
            ClientInfo.name = Request.Form["name"];
			ClientInfo.email = Request.Form["email"];
			ClientInfo.phone = Request.Form["phone"];
			ClientInfo.address = Request.Form["address"];

            if(ClientInfo.name.Length==0||ClientInfo.email.Length==00 || ClientInfo.phone.Length == 00 || ClientInfo.address.Length == 00)
            {
                errorMessage = "All the fileds are required";
                return;
            }

            ClientInfo.name = ""; ClientInfo.email = ""; ClientInfo.phone = ""; ClientInfo.address = "";
            successMessage = "New Client Added Correctly";
		}
	}
}
