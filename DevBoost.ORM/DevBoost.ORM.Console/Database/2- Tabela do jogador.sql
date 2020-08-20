Create Table Tb_Jogador(
Id_Jogador int identity primary  key, 
Nome varchar(50), 
Data_Nascimento Datetime2,  
Id_Clube int FOREIGN KEY REFERENCES Tb_Clube(Id_Clube)
)