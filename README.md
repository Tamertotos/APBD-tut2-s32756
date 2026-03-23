# APBD-tut2-s32756
APBD subject's second tutorial's assignment
1- Equipment class is abstract since we don't need to instantiate it. However, Laptop, Camera and Book classes inherits from this class.

2- To keep things simple, instead of creating abstract User class I added attribute type, so it is either Student or Teacher,its validation done by throwing an exception.

3- Whole rental system is in Rental abstract class and this class in inherited by StudentRental and TeacherRental. In these classes I implement limitations; student can rent maximum 2 equipments have to pay if overdue happens. TeacherRental has its own limitations and logic as well.

4- In Program.cs, main method I tested some by instantiating objects.

5- InventoryList class is for simply to show which equipments we have, which are damaged...
