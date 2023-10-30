



Create table Product
(
	Id int not null primary key identity,
	CategoryId int not null foreign key references Category,
	ProdName NChar(20) not null,
	ProdPrice float not null,
	ProdDesc nChar(20),
	ProdImage nChar(20)
)