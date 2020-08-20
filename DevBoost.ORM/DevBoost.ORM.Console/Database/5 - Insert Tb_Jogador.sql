declare @Id int 

select @Id = Id_Clube From Tb_Clube where upper(Clube) = upper('Palmeiras')

insert into Tb_Jogador values ('Lucas Cardoso','2020-08-19',@Id) 
insert into Tb_Jogador values ('Guilherme Cupertino','2017-08-19',@Id) 


select @Id = Id_Clube From Tb_Clube where upper(Clube) = upper('corinthians')
insert into Tb_Jogador values ('Marco Antonio','2019-08-19',@Id) 


select @Id = Id_Clube From Tb_Clube where upper(Clube) = upper('São paulo')
insert into Tb_Jogador values ('Flavio Henrique','2017-08-19',@Id) 
