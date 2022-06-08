using Microsoft.AspNetCore.Mvc;
using MVCdemo.Front.ViewModels;
using System.Collections.Generic;

namespace MVCdemo.Front.Controllers
{
    

    public class CAVController : Controller
    {
        // 0 懂在StartUp.cs更改預設網址，便於測試


        // 1 輸入 (路由要呼叫到正確的action 並傳入參數)
        // 1-1  Get收參數：
        // 1-1-1 request query string
        // 網址後面 ?i=3&s=Q&b=true
        //[HttpGet] (Get可省，共有七種)
        public IActionResult GetByQueryString
            //( string s , int i, bool b)
            ( [FromQuery]/*可省*/ DemoVM resquest )
        {
            return Content("");
        }

        // 1-1-2 Route template
        [HttpGet("~/{s}_{i}/{b}")]  //+= 在IIS server可能有問題
        //[Route("~/{s}-_{i}=+{b}")]
        public IActionResult GetByRoute
            //( string s , int i, bool b)
            ( [FromRoute]/*可省*/ DemoVM resquest)
        {
            return Content("");
        }

        // 1-1-3 混合試試
        [HttpGet("~/{s}")]
        public IActionResult Get
           // ([FromRoute] string s , [FromQuery] int i, [FromQuery] bool b)
            ( DemoVM resquest)
        {
            return Content("安安");
        }

        //-------------------------------------------
        // 1-2  Post收參數： (從首頁 做前端互動post過來)
        // 1-2-1 Form提交input欄位
        [HttpPost]
        public IActionResult PostByForm
            //( string s , int i,  bool b)
            ( /*[FromForm]可省 */DemoVM resquest)
        {
            return Content("");
        }

        // 1-2-2 AJAX夾帶body物件   
        [HttpPost]
        public IActionResult PostByAJAX
        //(string s, int i, bool b)
            ([FromBody]/*必備 */DemoVM resquest)
        {
            return Content("");
        }

        //網址是一個request => 
        //路由解析request 呼叫對應的action(方法，並傳入引數)
        //action 呼叫 View方法 經過一串處理，回傳response

        //2 傳資料給View 
        //2-1 傳資料給View的三種機制
        public IActionResult TestData()
        {
            //ViewData和ViewBag其實是同一套系統，key重疊會互蓋。 //(目前微軟較推ViewData)
            ViewData["p"] = "data";
            ViewBag.p = "bag";

            var response = View( model: "模型資料" );  //可指定參數，避免誤會
            return response;
        }

        //2-2 複雜的
        private List<DemoVM> _fakeList = new List<DemoVM>
        {
            new DemoVM{S="Q" , I=1 },
            new DemoVM{S="W" , I=2 },
            new DemoVM{S="E" , I=3 },
        };
        public IActionResult TestData2()
        {
            ViewData["p"] = _fakeList;

            ViewData["name"] = "軒";
            ViewData["height"] = 161;

            return View( _fakeList );
        }

        //3 View 迭代顯示收到的資料，配合模型DataAnnotation 
    }
}
