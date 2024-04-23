CREATE OR REPLACE VIEW vacancy_dashboard AS 
SELECT 
	vacancy_id AS Vacancy_id,
    (SELECT name FROM company_info ci WHERE ci.company_id = vc.company_id) AS Company_Name,
    job_location,
    no_of_vacancy,
    registation_start_date,
    registation_end_date,
    min_package AS Min_Package,
    max_package AS Max_Package,
    map_offering_id_to_name(vc.offering_id) AS offerings
FROM vacancy vc;