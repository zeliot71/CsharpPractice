// Class 14 Generic Parameter [24:52 - 1: 11: 00]
// Generic Constrain [1:12:00 - ]
//Generics: generics allow you to define reusable code that can work with different types of data.
//They provide a way to create classes, structures, methods, and interfaces that can work with multiple data types without sacrificing type safety.

using _25Generics;
using System.Data.SqlClient;

Point <string, double, SqlConnection> point= new Point<string,double,FileStream>(2);


