DELIMITER $$
CREATE PROCEDURE get_applied_companies(
  prn_number BIGINT
)
BEGIN
	SELECT 
	v.company_id,
    v.vacancy_id,
    ci.name,
    o.name as offering,
    v.registation_end_date,
	check_if_applied(prn_number,v.vacancy_id) AS status
	FROM vacancy v
    JOIN company_info ci
		using (company_id)
	join offering o
		ON v.offering_id = o.offering_id
	WHERE check_if_applied(prn_number,v.vacancy_id) = "Applied";

END$$
DELIMITER ;