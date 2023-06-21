// Class 14 Generic Parameter [24:52 - 1: 11: 00]
// Generic Constrain [1:12:00 - ]
//Generics: generics allow you to define reusable code that can work with different types of data.
//They provide a way to create classes, structures, methods, and interfaces that can work with multiple data types without sacrificing type safety.

using _25Generics;
using System.Data.SqlClient;
using System.Net;

Point <SqlCommand,double,SqlConnection> point= new Point<SqlCommand,double,SqlConnection>();

int x = default(int);
//it means x er default value set kora onno dike shudhu 'int x;' use korle run kora jabena!
 