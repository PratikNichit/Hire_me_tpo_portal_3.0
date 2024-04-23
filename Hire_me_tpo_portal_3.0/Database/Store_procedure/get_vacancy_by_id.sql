DELIMITER $$
CREATE PROCEDURE get_vacancy_by_id(
	id INT,
    companyId INT
)
BEGIN
	SELECT 
	(SELECT name FROM company_info ci WHERE ci.company_id = companyId) AS company_name,
    job_location,
    no_of_vacancy,
    registation_start_date,
    registation_end_date,
    min_package,
    max_package,
    map_offering_id_to_name(v.offering_id) AS offerings,
    map_boolean(dead_backlogs) AS dead_backlogs,
    map_boolean(current_backlogs) AS current_backlogs,
    map_boolean(year_down) AS year_down,
    map_boolean(pursuing_internship) AS pursuing_internship,
    candidate_type,
    stipend_amound,
    min_cgpa,
    min_ssc_percentage,
    min_hsc_percentage,
    min_diploma_percentage,
    vd.computer_science,
    vd.information_technology,
    vd.Artificial_Intelligence_and_Data_Science,
    vd.Artificial_Intelligence_and_machine_learning,
    vd.electronics_and_telecommunication,
    vd.instrumentation,
    vd.production,
    vd.chemical,
    ca.file_path
	FROM vacancy v
    JOIN vacancy_details vd ON vacancy_detail_id = vacany_details_id
    JOIN company_attachments ca ON  v.vacancy_id = vancay_id
    WHERE v.vacancy_id = id;
    
END $$
DELIMITER ;