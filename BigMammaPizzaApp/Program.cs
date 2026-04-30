using ClassLibPizza.Model;
using System.Collections.Generic;

List<Extratopping> extratoppings = new List<Extratopping>();
Pizza pizzamagaritha = new Pizza(1, "magaritha", 50, false, false, false, "tomato, cheese", true);
Pizza pizzavegan = new Pizza(2, "vegan", 60, true, false, false, "tomato, vegan cheese", true);
Pizza pizzavesuv = new Pizza(3, "vesuv", 70, false, false, false, "tomato, cheese, pepperoni", true);
Pizza pizzacalzone = new Pizza(4, "calzone", 80, false, true, false, "tomato, cheese, ham", true);
Pizza pizzagluten = new Pizza(5, "gluten", 90, false, false, true, "tomato, cheese, gluten", true);
Pizza pizzaveganCalzone = new Pizza(6, "vegan calzone", 100, true, true, false, "tomato, vegan cheese", true);
Pizza pizzanegro = new Pizza(7, "negro", 110, false, false, false, "tomato, cheese, black olives", true);
Pizza pizzaveganNegro = new Pizza(8,"vegan Negro", 120, true, false, false, "tomato, vegan cheese, black olives", true);
Pizza pizzaveganGluten = new Pizza(9, "vegan gluten", 130, true, false, true, "tomato, vegan cheese, gluten", true);
Pizza pizzahawaii = new Pizza(10, "hawaii", 140, false, false, false, "tomato, cheese, ham, pineapple", true);
Pizza pizzalava = new Pizza(11, "lava", 150, false, false, false, "tomato, cheese, pepperoni, jalapenos", true);
Pizza pizzaha = new Pizza(12, "ha", 160, false, false, false, "tomato, cheese, ham, pineapple, pepperoni", true);
Pizza pizzatonno = new Pizza(13, "tonno", 170, false, false, false, "tomato, cheese, tuna", true);
Pizza pizzaromana = new Pizza(14, "romana", 180, false, false, false, "tomato, cheese, anchovies", true);
Pizza pizzasole = new Pizza(15, "sole", 190, false, false, false, "tomato, cheese, tuna, anchovies", true);
Pizza pizzabigmama = new Pizza(16, "big mama", 200, false, false, false, "tomato, cheese, pepperoni, ham, pineapple, tuna, anchovies", true);
Pizza pizzashrimp = new Pizza(17, "shrimp", 210, false, false, false, "tomato, cheese, shrimp", true);
Pizza pizzaoyster = new Pizza(18, "oyster", 220, false, false, false, "tomato, cheese, oyster", true);



Extratopping tomato = new Extratopping(1, "Tomato", 25.00);

// Additional common pizza extratoppings (9 more)
Extratopping pepperoni = new Extratopping(2, "Pepperoni", 30.00);
Extratopping mushrooms = new Extratopping(3, "Mushrooms", 20.00);
Extratopping ham = new Extratopping(4, "Ham", 28.00);
Extratopping pineapple = new Extratopping(5, "Pineapple", 22.00);
Extratopping blackOlives = new Extratopping(6, "Black Olives", 18.00);
Extratopping jalapenos = new Extratopping(7, "Jalapenos", 17.00);
Extratopping onions = new Extratopping(8, "Onions", 15.00);
Extratopping bacon = new Extratopping(9, "Bacon", 35.00);
Extratopping basilicum = new Extratopping(10, "Basilicum", 12.00);
Extratopping shrimp = new Extratopping(11, "Shrimp", 40.00);


pizzavegan.AddExtratopping(tomato);
pizzavegan.AddExtratopping(pepperoni);
pizzavegan.AddExtratopping(mushrooms);
pizzavegan.AddExtratopping(ham);
pizzavegan.AddExtratopping(pineapple);
pizzavegan.AddExtratopping(blackOlives);
pizzavegan.AddExtratopping(jalapenos);
pizzavegan.AddExtratopping(onions);
pizzavegan.AddExtratopping(bacon);
pizzavegan.AddExtratopping(shrimp);

Console.WriteLine(pizzavegan);
Console.WriteLine(pizzamagaritha);

Console.WriteLine(pizzavegan.Totalprice());