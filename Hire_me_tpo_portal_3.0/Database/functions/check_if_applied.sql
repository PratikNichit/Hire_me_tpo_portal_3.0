DELIMITER $$
CREATE FUNCTION `check_if_applied`(
	prn_number BIGINT,
    vacancy_id INT
) RETURNS varchar(20)
    READS SQL DATA
BEGIN
	DECLARE status VARCHAR(20) DEFAULT 'not Applied';
    DECLARE application_no INT DEFAULT NULL;
    
	SELECT  application_id 
    INTO application_no
	FROM  applications a
        WHERE a.prn_number=prn_number 
        AND a.vacany_id =vacancy_id;
	if application_no IS NOT NULL THEN
		SELECT "Applied" into status;
    END IF;
RETURN status;
END $$
DELIMITER ;