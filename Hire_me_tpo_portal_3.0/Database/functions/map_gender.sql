DROP FUNCTION IF EXISTS map_gender;
DELIMITER $$
CREATE FUNCTION map_gender(
   gender_id INT
) RETURNS VARCHAR(20)
DETERMINISTIC 
BEGIN
	DECLARE gender VARCHAR(20) DEFAULT "Others";
	IF gender_id = 0 THEN
		SET gender = "Male";
	END IF;
    IF gender_id = 1 THEN
		SET gender = "Female";
	END IF;
    
	RETURN gender;
END $$
DELIMITER ;