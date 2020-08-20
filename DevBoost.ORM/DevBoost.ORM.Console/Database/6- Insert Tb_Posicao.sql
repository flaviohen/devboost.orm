declare @Id int 


select @Id = Id_Jogador from Tb_Jogador where  UPPER(NOME) = upper('lucas cardoso')
Insert into Tb_Posicao values('Goleiro', @Id)

select @Id = Id_Jogador from Tb_Jogador where  UPPER(NOME) = upper('guilherme cupertino')
Insert into Tb_Posicao values('Atacante', @Id)


select @Id = Id_Jogador from Tb_Jogador where  UPPER(NOME) = upper('Marco Antonio')
Insert into Tb_Posicao values('Centroavante', @Id)

select @Id = Id_Jogador from Tb_Jogador where  UPPER(NOME) = upper('Flavio Henrique')
Insert into Tb_Posicao values('Zagueiro', @Id)