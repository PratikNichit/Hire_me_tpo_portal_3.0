DELIMITER $$
CREATE PROCEDURE create_user(
	email_id VARCHAR(50),
    password VARCHAR(50),
    key_value BIGINT(10),
    user_type VARCHAR(45)
)
BEGIN

	IF user_type = "Student" THEN 
		INSERT INTO student_info(prn_number) VALUES(key_value);
		
		INSERT INTO users(email_id,password,prn_number,user_type)
		VALUES(email_id,password,key_value,user_type);
	ELSE 
		INSERT INTO admin(employee_id) VALUES(key_value);
        
		INSERT INTO users(email_id,password,employee_id,user_type)
		VALUES(email_id,password,key_value,user_type);
	END IF;
        
END $$
DELIMITER ;