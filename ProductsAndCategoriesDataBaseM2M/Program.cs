using ProductsAndCategoriesDataBaseM2M.Core;

using (var context = new AppDbContexts())
    {
        var query = from p in context.Products
                    join pc in context.ProductCategories on p.ProductID equals pc.ProductID into prodCat
                    from pc in prodCat.DefaultIfEmpty()
                    join c in context.Categories on pc.CategoryID equals c.CategoryID into cat
                    from c in cat.DefaultIfEmpty()
                    select new
                    {
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName
                    };

        foreach (var item in query)
        {
            Console.WriteLine($"Product: {item.ProductName}, Category: {(item.CategoryName ?? "None")}");
        }
    }
