DELIMITER $$
CREATE PROCEDURE update_students_personal_details(
   prn_number BIGINT,
   first_name VARCHAR(20),
   middle_name VARCHAR(20),
   last_name VARCHAR(20),
   branch_name VARCHAR(20),
   gender VARCHAR(20),
   birth_date DATE,
   nationality VARCHAR(20),
   contact_no  BIGINT,
   is_seda TINYINT,
   personal_email_id VARCHAR(50),
   alternate_contact_no BIGINT,
   adhar_card_no BIGINT(12),
   pan_card_no VARCHAR(30)
)
BEGIN
	UPDATE student_info si 
		SET si.first_name = first_name,
			si.middle_name = middle_name,
            si.last_name = last_name,
            si.branch_id = (SELECT program_id FROM programs WHERE program_name = "computer_science"),
            si.gender = map_gender(gender),
            si.birth_date = birth_date,
            si.nationality = nationality,
            si.contact_no = contact_no,
            si.is_seda = is_seda,
            si.personal_email_id = personal_email_id,
            si.alternate_contact_no = alternate_contact_no,
            si.adhar_card_no = adhar_card_no,
            si.pan_card_no = pan_card_no
	WHERE 
		si.prn_number = prn_number;
END $$
DELIMITER ;