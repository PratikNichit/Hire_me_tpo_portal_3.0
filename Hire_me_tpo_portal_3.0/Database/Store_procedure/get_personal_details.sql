DELIMITER $$
CREATE PROCEDURE get_personal_details(
  key_value BIGINT
)
BEGIN
SELECT 
	prn_number,
    first_name,
    middle_name,
    last_name,
    map_branch_id_to_name(branch_id) AS branch_name,
    gender,
    birth_date,
    nationality,
    contact_no,
    is_seda,
    current_address,
    `permanent _address` AS permanent_address,
    personal_email_id,
    alternate_contact_no,
    adhar_card_no,
    pan_card_no,
    pursuing_year,
    current_backlog,
    dead_backlog,
    current_cgpa,
    pursing_internship,
    is_placed
	FROM student_info si
	JOIN academics a using(prn_number)
WHERE prn_number = key_value;
END $$
DELIMITER ;
