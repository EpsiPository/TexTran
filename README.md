# TexTran

TexTran is a project that contains text transformation templates to generate classes from simple definitions. I started this project to discover what T4 has to offer.

Currently supported: 
- Entities
- Models
- Enums
- DbContext + DbSets

.NET Core 2.2 +
AutoT4 1.2.2

# Usage

Definitions are located in the `TextTran.Transformations\Definitions` folder.

Example Entity defintion file:

``` txt
User
	Id:Guid
	FirstName:string
	LastName:string
	Email:string
	Phone:string

Product
	Id:Guid
	Name:string
	Price:decimal
	Category:string

Order
	Id:Guid
	Products:List<Product>
	Price:decimal
```

In this project, Entities are generated in separate files. 
Models/Enums for example are generated in a single CS file, but this can be changed as needed.

Generated Entity example:
``` csharp
// This file is auto generated. Changes to these files will be lost! 
using System;
using System.Collections.Generic;

namespace TexTran.Data.Abstractions.Entities
{
	public class Order
	{
		public Guid Id { get; set; }
		public List<Product> Products { get; set; }
		public decimal Price { get; set; }
	}
}
```
After adding more content to the definitions, just run `Build > Transform all T4 templates` to re-generate all code. If you added an Entity, there will also be a DbSet<Entity> added to the generated DbContext.

# TODO

- Nullable types support
- Summary/comment support
- Generate repositories
