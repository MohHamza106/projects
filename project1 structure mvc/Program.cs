using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace project1_structure_mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();



            #region routing 
            ////////////////////////////////////
            // process  mapping http request to specific  controller action or end point 
            //two type
            //1 conventional routing
            //2 attribute routing 
            // routing may be static segment or variable segment or max segment [static and variable ]
            //////////////////////////////////////////////////
            //app.MapGet("/{name}", async context =>
            //{
            //    var Name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($" () => Hello World!{Name}");



            //});
            ////////////////
            //routing to class controller
            // how to segment optional take ?
            ////////////////////
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id:int?}",// id is optional
             defaults: new {actio= "Index" } , // if no enter action default
              constraints: new { Id = new IntRouteConstraint()});


            #endregion
            #region action
            //requirement/////////////
            //action is method public and non static in controller
            // can not constructor and extension method and getter and setter and generic type
            // can not method in controller bases class
            // method parameter can not out or ref 
            // if action clr can be invoke request 
            ///////////////////////
            ///action return type /////////
            /// 1:view result : support html and  markup method in controller bases(view)
            /// 2: empty result : support no result 
            /// 3: redirect result : support new url method in controller bases(redirect)
            /// 4: json result : support javaScript object  ued more app method in controller bases(json)
            /// 5:javaScript  result :  support javaScript method in controller bases(javaScript)
            /// 6:content result : support text result method in controller bases(content )
            /// 7: file content result : download  file (binary content)
            /// 8:file path result : download file  (with path)
            /// 9:file stream result: download  file (with stream) 
            /// /////////////
            ///  all action result inheritance in action result class
            #endregion
            #region model  binding
            // process used automatic
            // mappping http request data to enter parameter action or properties to model
            //type of model data 
            //1: simple data (one attribute)
            //2: complex data(more attribute)
            //3: maxed data (complex and simple)
            //4: collection data (array return index)
            //data
            //1:from
            //2: route data
            //3: query string 
            //4: request body
            //4: request header 
            #endregion
            #region client side library
            //library contains front end  resources can be mange library 
            // mange library two way
            // 1:download  library by (library manger)
            //2: by used cdn (link)
            #endregion
            #region view
            //handle app data to repersent and user interaction 
            // is html template 
            #endregion
            #region layout 
            //special type of view  
            // used to same structure  multiple page in the app
            // con not duplication to code 
            #endregion
            #region tag helpers
            //feature to help  to add server side logic  to html 
            #endregion

            app.Run();
        }
    }
}
