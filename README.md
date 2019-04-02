# TexTran

TexTran is a project that contains `T4 templates` to generate classes from simple definitions. I started this project to discover what `T4` has to offer and how I can use this in future projects. 

## Technologies

- .NET Core 2.2
- Entity Framework Core 2 + FluentAPI
- AutoT4 1.2.2

## Usage

Just define classes in the definition files, and build the solution.

### Entity example

Add a definition for a entity to the definition file (`EntityDefinitions.txt`). Save the file, build the solution and following files are generated:
- {Entity}.cs inside `TexTran.Data.Abstractions\Entities`
- {Entity}Repository.cs inside `TexTran.Data.Access\Repositories`
- I{Entity}Repository.cs inside `TexTran.Data.Abstractions\Interfaces`
- DbContext.cs + DbSet<{Entity}> inside `TexTran.Data.Access\Context` 
- If you add a `IEntityTypeConfiguration<{Entity}>` this will also be added to the `OnModelCreating()` of the generated `DbContext` 

Example Entity defintion file:

``` txt
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
After adding more content to the definitions, just run `Build > Transform all T4 templates` or build the solution to re-generate all code. If you added an `Entity`, there will also be a `DbSet<Entity>` added to the generated DbContext. `EntityTypeConfigurations` have to be written manually, but these are also added to the `DbContext` when transforming the templates. 

### Set up DB

You can set the DbContextName in `TexTran.Transformer.TransformDirectives.ttinclude`.
Add your entities to the definition files and run a `Add-Migration Initial` command in the Package Manager Console followed by `Update-Database` to create the database. Don't forget to create a migration every time you change the database model.

## TO DO

- Implement AutoMapper + auto generate mappings
- Complete the Service layer
