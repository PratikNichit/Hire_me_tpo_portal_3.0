DELIMITER $$
CREATE FUNCTION check_user_type(
    user_type VARCHAR(20),
    email_id VARCHAR(40)
) RETURNS BIGINT
READS SQL DATA
BEGIN
    DECLARE key_value BIGINT DEFAULT NULL;
    DECLARE prn_number BIGINT DEFAULT NULL;
    DECLARE employee_id BIGINT DEFAULT NULL;

    SELECT u.prn_number, u.employee_id
    INTO prn_number, employee_id 
    FROM users u 
    WHERE u.user_type = user_type AND u.email_id = email_id;

    IF prn_number IS NOT NULL THEN 
        SET key_value = prn_number;
    ELSE
        SET key_value = employee_id;
    END IF;

    RETURN key_value;
END $$
DELIMITER ;