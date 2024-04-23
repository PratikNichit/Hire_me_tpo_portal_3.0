DELIMITER $$
CREATE PROCEDURE insert_into_Applications(
	id INT,
    id_vacancy INT,
    id_company INT,
	registation_start DATE
)
BEGIN 
	INSERT INTO applications 
    VALUES(DEFAULT,id,id_vacancy,id_company,NOW(),"Applied",registation_start);
END $$
DELIMITER ;