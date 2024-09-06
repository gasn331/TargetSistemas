SELECT 
    C.ID AS CodigoCliente,
    C.RazaoSocial,
    T.Numero AS Telefone
FROM 
    CLIENTES C
    JOIN ESTADOS E ON C.EstadoID = E.ID
    JOIN TELEFONES T ON C.ID = T.ClienteID
WHERE 
    E.Sigla = 'SP';
