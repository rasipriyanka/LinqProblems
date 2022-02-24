using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeProblems
{
    internal class AddList
    {
        public static List<ProductMangement> list = new List<ProductMangement>();
        public static List<ProductMangement> ProductMangement()
        {
            List<ProductMangement> list = new List<ProductMangement>()
            {

                new ProductMangement() { ProductId = 4, UserId = "ttt@gmail.com", Review = "Good", Rating = 17, IsLike = true },
                new ProductMangement() { ProductId = 7, UserId = "kkk@gmail.com", Review = "bad", Rating = 10, IsLike = false },
                new ProductMangement() { ProductId = 8, UserId = "abc@gmail.com", Review = "good", Rating = 18, IsLike = true },
                new ProductMangement() { ProductId = 9, UserId = "gif@gmail.com", Review = "good", Rating = 20, IsLike = true },
                new ProductMangement() { ProductId = 10, UserId = "facebook@gmail.com", Review = "average", Rating = 13, IsLike = false }
            };
            IterateOverProductList(list);
            return list;
        }
        public static void IterateOverProductList(List<ProductMangement> list)
        {
            try
            {
                foreach (ProductMangement person in list)
                {
                    Console.WriteLine("ProductId:" + person.ProductId + "----" + "User Id:" + person.UserId + "-----" + "Review :" + person.Review + "-----" + "Rating :" + person.Rating + "------" + "IsLike :" + person.IsLike);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


