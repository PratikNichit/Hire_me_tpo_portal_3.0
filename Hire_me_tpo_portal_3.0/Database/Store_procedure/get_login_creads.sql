DELIMITER $$
CREATE PROCEDURE get_login_creads(
  email VARCHAR(40),
  pass VARCHAR(40)
)
BEGIN
SELECT 
	email_id,
    password,    
    user_type,
    check_user_type(user_type,email_id) as key_value
FROM users WHERE email_id = email AND password = pass;
END $$
DELIMITER ;