using ClassLibPizza.Model;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

List<Extratopping> extratoppings = new List<Extratopping>();
Pizza pizzamagaritha = new Pizza(1, "magaritha", 50, false, false, false, "tomato, cheese", true, extratoppings);
Pizza pizzavegan = new Pizza(2, "vegan", 60, true, false, false, "tomato, vegan cheese", true, extratoppings);
Pizza pizzavesuv = new Pizza(3, "vesuv", 70, false, false, false, "tomato, cheese, pepperoni", true, extratoppings);
Pizza pizzacalzone = new Pizza(4, "calzone", 80, false, true, false, "tomato, cheese, ham", true, extratoppings);
Pizza pizzagluten = new Pizza(5, "gluten", 90, false, false, true, "tomato, cheese, gluten", true, extratoppings);
Pizza pizzaveganCalzone = new Pizza(6, "vegan calzone", 100, true, true, false, "tomato, vegan cheese", true, extratoppings);
Pizza pizzanegro = new Pizza(7, "negro", 110, false, false, false, "tomato, cheese, black olives", true, extratoppings);
Pizza pizzaveganNegro = new Pizza(8,"vegan Negro", 120, true, false, false, "tomato, vegan cheese, black olives", true, extratoppings);
Pizza pizzaveganGluten = new Pizza(9, "vegan gluten", 130, true, false, true, "tomato, vegan cheese, gluten", true, extratoppings);
Pizza pizzahawaii = new Pizza(10, "hawaii", 140, false, false, false, "tomato, cheese, ham, pineapple", true, extratoppings);
Pizza pizzalava = new Pizza(11, "lava", 150, false, false, false, "tomato, cheese, pepperoni, jalapenos", true, extratoppings);
Pizza pizzaha = new Pizza(12, "ha", 160, false, false, false, "tomato, cheese, ham, pineapple, pepperoni", true, extratoppings);
Pizza pizzatonno = new Pizza(13, "tonno", 170, false, false, false, "tomato, cheese, tuna", true, extratoppings);
Pizza pizzaromana = new Pizza(14, "romana", 180, false, false, false, "tomato, cheese, anchovies", true, extratoppings);
Pizza pizzasole = new Pizza(15, "sole", 190, false, false, false, "tomato, cheese, tuna, anchovies", true, extratoppings);
Pizza pizzabigmama = new Pizza(16, "big mama", 200, false, false, false, "tomato, cheese, pepperoni, ham, pineapple, tuna, anchovies", true, extratoppings);
Pizza pizzashrimp = new Pizza(17, "shrimp", 210, false, false, false, "tomato, cheese, shrimp", true, extratoppings);
Pizza pizzaoyster = new Pizza(18, "oyster", 220, false, false, false, "tomato, cheese, oyster", true, extratoppings);



Extratopping tomato = new Extratopping(1, "name", 25.00);

pizzavegan.AddExtratopping(tomato);


Console.WriteLine(pizzavegan);
Console.WriteLine(pizzamagaritha);