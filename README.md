# TexTran

TexTran is a project that contains text transformation templates to generate classes from simple definitions. I started this project to discover what T4 has to offer and how I can use this in future projects.

Currently generated: 
- Entities
- Models
- Enums
- DbContext + DbSets

## Technologies

- .NET Core 2.2
- Entity Framework Core 2 + FluentAPI
- AutoT4 1.2.2

## Usage

Example Entity defintion file:

``` txt
User
	FirstName : string
	LastName : string
	Email : string
	Phone : string

Product
	Name : string
	Price : decimal
	Category : string

Order // Description of order
	Products : List<Product>
	Price : decimal
	Quantity : int?
```

Generated Entity example:
``` csharp
// This file is auto generated. Changes to these files will be lost! 
using System;
using System.Collections.Generic;

namespace TexTran.Data.Abstractions.Entities
{
	/// <summary>
	/// Description of order
	/// </summary>
	public class Order : BaseEntity
	{
		public List<Product> Products { get; set; }
		
		public decimal Price { get; set; }
		
		public int? Quantity { get; set; }
	}
}
```
After adding more content to the definitions, just run `Build > Transform all T4 templates` or build the solution to re-generate all code. If you added an Entity, there will also be a DbSet<Entity> added to the generated DbContext. EntityTypeConfigurations have to be written manually, but are automatically added to the context when transforming templated.

** This is still a work in progress **
