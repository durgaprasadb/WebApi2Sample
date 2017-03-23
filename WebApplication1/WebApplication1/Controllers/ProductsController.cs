using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product { ProductID = 1, ProductName = "Product 1", ProductCategory= "Category 1", Price = 120 },
            new Product { ProductID = 2, ProductName = "Product 2", ProductCategory= "Category 1", Price = 100 },
            new Product { ProductID = 3, ProductName = "Product 3", ProductCategory= "Category 2", Price = 150 },
            new Product { ProductID = 4, ProductName = "Product 4", ProductCategory= "Category 3", Price = 90 }
        };
        //public IEnumerable<Product> GetProducts()
        //{
        //    return products;
        //}

        public IHttpActionResult GetProducts()
        {
            return Json(products);
        }

        //http://www.dotnetcurry.com/aspnet/1278/aspnet-webapi-pass-multiple-parameters-action-method
        //ASP.NET Web API: Passing Multiple Objects as an Input Parameters to Action Method
        //Approach 1: Using ViewModel object
        //{
        //    order: {CustomerName:'MS'},
        //    itemDetails:[
        //        {itemName: 'I1', Quantity:100, UnitPrice:1000, OrderId:1},
        //        {itemName: 'I1', Quantity:100,UnitPrice:1000, OrderId:1},
        //    ]
        //}

        //Content-Type:"application/json"
        public IHttpActionResult Post(OrderItemDetailsViewModel orderInfo)
        {
            Order ord = orderInfo.order;
            var ordDetails = orderInfo.itemDetails;
            return Ok();
        }


        //Approach 2: Using Json.Net with Newtonsoft.Json
        //JSON.Net is an excellent framework used in .NET applications using which we can easily read JSON data and manage serialization and deserialization of JSON data. 
        //We can handle our use case using JObject. 
        //This represent the JSON object and this can be used to read JSON data posted using Http request.
        //var order = {
        //    "CustomerName":"MS"
        //};
        ////2.
        //var itemDetails = [
        //    { "ItemName": "Desktop", "Quantity": 10, "UnitPrice": 45000 },
        //    { "ItemName": "Laptop", "Quantity": 30, "UnitPrice": 80000 },
        //    { "ItemName": "Router", "Quantity": 50, "UnitPrice": 5000 }
        //];
        //public IHttpActionResult Post(JObject objData)
        //{
        //    List<ItemDetails> lstItemDetails = new List<ItemDetails>();

        //    //1. The received data to the post method is stored in the dynamic object.
        //    dynamic jsonData = objData;

        //    //2. We are reading the order key data from the posted data in the JObject object.
        //    JObject orderJson = jsonData.order;

        //    //3. The itemDetails received from the request will be stored in JArray - this is the JSON array.
        //    JArray itemDetailsJson = jsonData.itemDetails;

        //    //4. The received order data is deserialized in the Order object.
        //    var Order = orderJson.ToObject<Order>();

        //    //5. The itemDetails are deserialized into the List of ItemDetails object.
        //    foreach (var item in itemDetailsJson)
        //    {
        //        lstItemDetails.Add(item.ToObject<ItemDetails>());
        //    }

        //    //7.
        //    foreach (ItemDetails itemDetail in lstItemDetails)
        //    {
        //        //ctx.ItemDetails.Add(itemDetail);
        //    }

        //    //ctx.SaveChanges();

        //    return Ok();
        //}

        //http://www.dotnettricks.com/learn/webapi/passing-multiple-complex-type-parameters-to-aspnet-web-api
        //Method 1 : Using ArrayList
        //or passing multiple complex types to your Web API controller, 
        //add your complex types to ArrayList and pass it to your Web API actions as given below-



        //Method 2 : Using Newtonsoft JArray
        //For passing multiple complex types to your Web API controller, 
        //you can also add your complex types to JArray and pass it to your Web API actions as given below-

        //MUST READ THIS
        //https://weblog.west-wind.com/posts/2012/may/08/passing-multiple-post-parameters-to-web-api-controller-methods

        //PERFECT
        //Web API 2 Exploring Parameter Binding
        //https://damienbod.com/2014/08/22/web-api-2-exploring-parameter-binding/

        //http://techbrij.com/pass-parameters-aspdotnet-webapi-jquery

        //https://docs.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api

        //https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api

        //https://dotnetcodr.com/2014/04/03/introduction-to-net-web-api-2-with-c-part-1/

        //https://blog.codeinside.eu/2015/04/17/basic-authentication-in-aspnet-webapi/

        //How to secure Web APIs using authorization filters
        //Take advantage of authorization filters to authorize incoming requests to your Web API
        //http://www.infoworld.com/article/2988903/application-architecture/how-to-secure-web-api-using-authorization-filters.html
    }
}
