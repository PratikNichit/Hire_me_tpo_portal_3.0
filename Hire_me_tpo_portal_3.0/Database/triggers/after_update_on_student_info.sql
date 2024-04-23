DELIMITER $$
CREATE TRIGGER after_update_on_student_info
	AFTER UPDATE ON student_info
    FOR EACH ROW
BEGIN
	IF (NEW.prn_number IS NOT NULL AND 
        NEW.first_name IS NOT NULL AND 
        NEW.middle_name IS NOT NULL AND 
        NEW.last_name IS NOT NULL AND 
        NEW.branch_id IS NOT NULL AND 
        NEW.gender IS NOT NULL AND 
        NEW.birth_date IS NOT NULL AND 
        NEW.nationality IS NOT NULL AND 
        NEW.contact_no IS NOT NULL AND 
        NEW.is_seda IS NOT NULL AND 
        NEW.current_address IS NOT NULL AND 
        NEW.`permanent _address`  IS NOT NULL AND 
        NEW.resume_link IS NOT NULL AND 
        NEW.personal_email_id IS NOT NULL AND 
        NEW.alternate_contact_no IS NOT NULL AND 
        NEW.adhar_card_no IS NOT NULL AND 
        NEW.pan_card_no IS NOT NULL) THEN
        UPDATE users u
        SET profile_status = 1 
        WHERE u.prn_number = NEW.prn_number;
        END IF;
END $$
DELIMITER ;