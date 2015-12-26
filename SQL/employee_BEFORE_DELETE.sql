CREATE DEFINER=`root`@`localhost` TRIGGER `expressdata`.`employee_BEFORE_DELETE` 
BEFORE DELETE ON `employee` 
FOR EACH ROW
BEGIN
	UPDATE `employee_transport` 
    SET `employee_id` = 1 
    WHERE `charge` = 1 AND old.employee_id = `employee_transport`.`employee_id`;
    
    DELETE 
    FROM `employee_transport` 
    WHERE old.employee_id = `employee_transport`.`employee_id`;
END