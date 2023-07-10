using OOP_Home_work2__UserAutorization_;

var userManager = new UserManager();

// Добавляем пользователей
userManager.AddUser("user1", "password1");
userManager.AddUser("user2", "password2");
userManager.AddUser("user3", "password3");

// Аутентифицируем пользователей
Console.WriteLine(userManager.Authenticate("user1", "password1")); // true
Console.WriteLine(userManager.Authenticate("user2", "password3")); // false
Console.WriteLine(userManager.Authenticate("user4", "password4")); // false

