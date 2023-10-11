using Microsoft.AspNetCore.Mvc;
using MoviesAppProjectFSD.Models;
using MoviesAppProjectFSD.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAppProjectFSD.Controllers
{
    public class CartController : Controller
    {

        private readonly FSWD22_sing5458_FSWD22ProjectContext _context;

        public CartController(FSWD22_sing5458_FSWD22ProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            //ViewBag.cart = cart;
            //ViewBag.total = cart.Sum(item => item.Movie.Price * item.Quantity);

            ViewBag.CartPage = from Moviess in _context.Movies
                           join cart in _context.Cart_Tbl
                           on Moviess.Id equals cart.Movie_ID
                           select new CartPageVM
                           {
                               CartSL = cart.SL,
                               MovieName = Moviess.Name,
                               ImageURL = Moviess.ImageUrl,
                               Price = Moviess.Price,

                           };

            return View();
        }



        public IActionResult Add_To_Cart(int id)
        {
            Cart_Tbl cart_Tbl = new Cart_Tbl
            {
                Movie_ID = id
            };

            _context.Cart_Tbl.Add(cart_Tbl);
            _context.SaveChanges();

            return new JsonResult("Success");
        }


        public IActionResult RemoveCart(decimal id)
        {
            var Remove = _context.Cart_Tbl.Where(x => x.SL == id).SingleOrDefault();

            _context.Cart_Tbl.Remove(Remove);
            _context.SaveChanges();

            return RedirectToAction(actionName: "Index", controllerName: "Cart");
        }

     

        [Route("remove/{id}")]
        public IActionResult Remove(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Movie.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }





    }
}
