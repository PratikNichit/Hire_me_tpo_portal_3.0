DELIMITER $$
	CREATE FUNCTION map_gender_to_id(
	   gender VARCHAR(20)
	) RETURNS INT 
		DETERMINISTIC
	BEGIN
		DECLARE gender_id INT DEFAULT 2;
		IF gender = "Male" THEN
			SET gender_id = 0;
		END IF;
		IF gender = "Female" THEN
			SET gender_id = 1;
		END IF;
		
		RETURN gender_id;
	END$$
DELIMITER ;
