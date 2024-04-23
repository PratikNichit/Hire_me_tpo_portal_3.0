CREATE OR REPLACE VIEW export_applcation_data AS 
SELECT 
	ap.vacany_id,
	ap.application_id,
	ap.prn_number,
    CONCAT(si.first_name,si.last_name) AS student_name,
    ap.date_applied,
    si.personal_email_id
	FROM applications ap 
	JOIN student_info si USING(prn_number);