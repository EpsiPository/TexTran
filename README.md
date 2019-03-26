# TexTran

TexTran is a project that contains text transformation templates to generate classes from simple definitions.

Currently supported: 
- Entities
- Models
- Enums

.NET Core 2.2 +

# Usage

Definitions are located in the `TextTran.Transformations\Definitions` folder.

Example defintion:

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

Generated example:
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

