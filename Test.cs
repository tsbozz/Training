using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using System.ComponentModel.DataAnnotations;

namespace TestT.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGet()
        {
            //Message += $" Server time is { DateTime.Now }";
        }

        //public void OnPost(string message)
        //{

        //    //var t = Request.Form["Message"].ToString();
        //    //Message = t;


        //    Console.WriteLine(message);

        //    this.Message = message;

        //}

        public void OnPost(FormThom formThorm)
        {

            //var t = Request.Form["Message"].ToString();
            //Message = t;

            if (ModelState.IsValid)
            {

            }


            Console.WriteLine(formThorm.Message);

            this.Message = formThorm.Message;

        }

    }

  
    public class FormThom
    {
        [Required, StringLength(10), MinLength(10)]
        public string Message { get; set; }
    }

}
