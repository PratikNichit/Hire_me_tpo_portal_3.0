DROP PROCEDURE IF EXISTS create_student_user;
DELIMITER $$
CREATE PROCEDURE create_student_user(
	email_id VARCHAR(50),
    password VARCHAR(50),
    prn_number BIGINT(10),
    user_type VARCHAR(45)
)
BEGIN

	INSERT INTO student_info(prn_number) VALUES(prn_number);
    
    INSERT INTO users(email_id,password,prn_number,user_type)
	VALUES(email_id,password,prn_number,user_type);
END $$
DELIMITER ;