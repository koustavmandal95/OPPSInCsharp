# Opps concepts 
    
Abstarct Class : It cannot be instiantiated only inheritance is possible  </br>

```cs
    public abstract class Product
    {
        public virtual useProduct(int items)
        {
            // base keyword 
        }
    } 

    Product a = new Product() // error Not allowed

    public class BoxedProduct : Product
    {
        public new useProduct(int items)
        {
            // Derived Implementation 
        }
    }

Product derivedproduct = new BoxedProduct();
```   