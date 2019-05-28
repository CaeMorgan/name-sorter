# name-sorter
.NET Core CLI program for sorting lists of names from a .txt file

Takes list of names as an argument in format:

Janet Parsons<br>
Vaughn Lewis<br>
Adonis Julius Archer<br>
Shelby Nathan Yoder<br>
Marin Alvarez<br>
London Lindsey<br>
Beau Tristan Bentley<br>
Leo Gardner<br>
Hunter Uriah Mathew Clarke<br>
Mikayla Lopez<br>
Frankie Conner Ritter<br>

and outputs a sorted list of names to command line and sorted-names-list.txt file in the working directory. i.e:

Marin Alvarez<br>
Adonis Julius Archer<br>
Beau Tristan Bentley<br>
Hunter Uriah Mathew Clarke<br>
Leo Gardner<br>
Vaughn Lewis<br>
London Lindsey<br>
Mikayla Lopez<br>
Janet Parsons<br>
Frankie Conner Ritter<br>
Shelby Nathan Yoder<br>


To run from directory using command line and supplied list:

name-sorter ./unsorted-names-list.txt

