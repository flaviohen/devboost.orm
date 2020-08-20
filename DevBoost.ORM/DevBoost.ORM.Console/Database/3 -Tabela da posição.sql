Create table Tb_Posicao(
Id_Posicao int identity primary key, 
Posicao varchar(30), 
Id_Jogador int FOREIGN KEY REFERENCES Tb_Jogador(Id_Jogador)
)