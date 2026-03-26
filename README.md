# Vehicle (inheritance)
Vehicle
       |
       + Car
       + Bike
       + Truck
Vehicle
  ● Speed
  ● Start()
Car
  ● NumberOfDoors
Bike
  ● HasPedals
Truck
  ● LoadCapacity

# Bank
Առաջադրանք — BankAccount v2
Պահանջներ 👇
● _balance → private
● Public մեթոդներ
○ Deposit(amount)
○ Withdraw(amount)
○ Balance (read-only property)
● Թույլ չտալ բացասական balance
Bonus (⭐)
● Ավելացնել TransferTo(BankAccount other, amount)

# Order
Առաջադրանք — Order
Պահանջներ 👇
● Order
○ OrderNumber 
○ CreatedDate (constructor-ում)
○ Items (List)
● Չթողնել Order առանց OrderNumber
Bonus (⭐)
● Արգելել Items == null
● Ստեղծել 2 constructor (chaining-ով)

# LibraryBook
Գրիր class LibraryBook, որը․
● Ունի Title, Author, Year,
● Ունի 3 կոնստրուկտոր (default, 2-param, 3-param),
● Constructor chaining կիրառիր,
● Console demo՝ ստեղծիր տարբեր տարբերակներով և տպիր։

# House
Առաջադրանք
Ստեղծել House class
○ ունի Room-ներ (composition)

# Teacher_Course
Ստեղծել Teacher և Course
○ Teacher-ը դասավանդում է Course (aggregation)


