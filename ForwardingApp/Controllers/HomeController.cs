using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ForwardingApp.Models;

namespace ForwardingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private int _minPartCount = 2;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (var context = new ForwardingAppContext())
            {
                RenderPartCountofBox();
                RenderDetailofPart();
                
                
                var PartList = context.Parts.OrderBy(p => p.BoxId).ThenBy(p => p.PartNumber).ToList();
                return View(PartList);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void RenderPartCountofBox()
        {
            using (var context = new ForwardingAppContext())
            {
                //Paketler agirliklarina göre kücükten büyüge siralandi
               var sortingOrder = context.Orders.OrderBy(s => s.Weight);
            
               var BoxList = context.Boxes.ToList();
               //Her paketin parça sayısını belirlendi ve ilgili tabloya yazildi 
               foreach (var item in sortingOrder.ToList())
               {
                   if(BoxList.Where(b => b.BoxId == item.BoxId).FirstOrDefault() == null)
                   {
                        Box bx = new Box();
                        bx.BoxId = item.BoxId;
                        bx.PartCount = _minPartCount;
                        context.Boxes.Add(bx);
                        _minPartCount++;
                   }
               }

               context.SaveChanges();
            }
        }

        public void RenderDetailofPart()
        {
            using (var context = new ForwardingAppContext())
            {
                var query = (from order in context.Set<Order>()
                                join box in context.Set<Box>()
                                    on order.BoxId equals box.BoxId
                                select new { order, box }).OrderBy(w => w.order.Weight);

                int mod = 0;
                Part p;

                var PartList = context.Parts.ToList();
                //Her parçaya ait ağırlıklar ve maliyetleri hesaplandi ve tabloya yazildi 
                foreach (var item in query)
                {
                    if(PartList.Where(b => b.BoxId == item.box.BoxId).FirstOrDefault() == null)
                    {
                        mod = item.order.Weight % item.box.PartCount;//mod parca agirligi hesaplamasi icin
                        for (int i = 1; i <= item.box.PartCount; i++)
                        {
                            p = new Part();
                            p.PartNumber = i;
                            p.BoxId = item.box.BoxId;

                            if (mod == 0)
                            {
                                p.PartWeight = item.order.Weight / item.box.PartCount;
                            }
                            else
                            {
                                p.PartWeight = item.order.Weight / item.box.PartCount;
                                if( i == item.box.PartCount)
                                    p.PartWeight = (item.order.Weight / item.box.PartCount) + 1;
                                
                            }
                            p.PartCost = 50 + (p.PartWeight * 7); //maliyet hesaplama
                            context.Parts.Add(p);
                        }
                    }
                }
                context.SaveChanges();
            }   
        }
    }
}
