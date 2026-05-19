### Static Constructors and fields in C#

First static constructor is needed then the instance constructor can assign the static field .
The first time you construct a BankCustomer, the static constructor runs once, initializing s_nextCustomerId with a random number.
Then your instance constructor runs, assigns CustomerId, and sets s_nextCustomerId = 88.
Every subsequent BankCustomer you create will see that static field already set to 88 (or whatever you last assigned).

### ReadOnly fields in C#
It can be assigned in the declaration or in a constructor, but not both. If you assign it in the declaration, you cannot assign it again in the constructor. 
If you try to do both, you'll get a compile-time error.