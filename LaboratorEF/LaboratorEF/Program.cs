using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scenariu 1
            //Console.WriteLine("Test1");
            //Test1();

            //Scenariu 2
            //Console.WriteLine("Test2");
            //Test2();

            //Scenariu 3
            Console.WriteLine("Test3");
            Test3();

        }

        public static void Test1()
        {
            using (var context = new ModelSelfReferences())
            {
                var selfR = new SelfReference
                {
                    Name = "Ceva"
            };
                var selfR2 = new SelfReference
                {
                    Name = "Altceva"
            };
                context.SelfReferences.Add(selfR);
                context.SelfReferences.Add(selfR2);
                context.SaveChanges();
            }

            using (var context = new ModelSelfReferences())
            {
                foreach (var sr in context.SelfReferences)
                {
                    Console.WriteLine("{0} {1} ", sr.SelfReferenceId, sr.Name);
                }
            }

        }

        public static void Test2()
        {
            using (var context = new ProductContext())
{
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageURL = "/noimage.jp"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageURL = "/pack202.jpg"
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
            using (var context = new ProductContext())
{
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                }
            }

        }

        public static void Test3()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new PhotographContext())
{
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                fullBits
                };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }
            using (var context = new PhotographContext())
{
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    context.Entry(photo)
                    .Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                    photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }
        }
    }
}
