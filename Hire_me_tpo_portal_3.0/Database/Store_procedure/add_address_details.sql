DELIMITER $$
CREATE PROCEDURE add_address_details(
	prn_number BIGINT,
	current VARCHAR(100),
    permanent VARCHAR(100)
)
BEGIN
	UPDATE student_info si
		SET current_address = current,
			`permanent _address` = permanent
	WHERE si.prn_number = prn_number;
END $$
DELIMITER ;