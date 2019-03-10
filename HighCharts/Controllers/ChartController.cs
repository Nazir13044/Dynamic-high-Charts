using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HighCharts.Models;

namespace HighCharts.Controllers
{
    public class ChartController : Controller
    {
        private readonly WKPIEntities1 _entity = new WKPIEntities1();
        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult GetData()
        //{


        //    int[] a = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
        //    int[] b = { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
        //    int[] c = { 10001, 11111, 12135, 23121, 32112, 23121, 33121, 21153, 32110, 21103, 21223, 22101 };


        //    var d = new[]  
        //    {
        //            new
        //            {
        //                name = "Target",
        //                data = a
        //            },
        //            new
        //            {
        //                name = "Average",
        //                data = b
        //            },
        //            new
        //            {
        //                name = "Actual",
        //                data = c
        //            }         
        //    };

        //    return Json(d);
        //}
        public JsonResult GetData()
        {
            var targetList=new ArrayList();
            var actualList = new ArrayList();
            var Values = new ArrayList();

            var list = (from k in _entity.AssignKPIDetails
                group k by new {k.AssignKPIId}
                into g
                select new KPIModels
                {
                    kpiId = g.Key.AssignKPIId
                }
                ).ToList();

            foreach (var v in list)
            {
                
                var x = (from k in _entity.AssignKPIDetails 
                         join h in _entity.AssignedKpiLogs on k.AssignKPIId equals h.AssignKpiId
                         where k.ActualDate != null && ((DateTime)(k.ActualDate)).Month == h.MonthNumber && k.AssignKPIId==v.kpiId
                          select new KPIModels
                    {
                       kpiId = k.AssignKPIId,                      
                        Actual = k.Actual,
                        Target = h.CurrentTarget
                    } 


                    ).ToList();

                Values.Add(x);
            }

            return Json(Values);
        }       
    }
}