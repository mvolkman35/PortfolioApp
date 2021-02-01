CREATE DATABASE portfolio_app;

use portfolio_app;
/* modified to add calcualtion col */
CREATE TABLE holdings
(
	holding_id 	INT 			PRIMARY KEY 	auto_increment,
	ticker 		VARCHAR(6)		NOT NULL 		UNIQUE,
    quantity 	DECIMAL(13,2)	NOT NULL 		DEFAULT 0,
    position_val DECIMAL(13,2)	NOT NULL		DEFAULT 0
)

CREATE TABLE holdings
(
	holding_id 	INT 			PRIMARY KEY 	auto_increment,
	ticker 		VARCHAR(6)		NOT NULL 		UNIQUE,
    quantity 	DECIMAL(13,2)	NOT NULL 		DEFAULT 0,
    position_val DECIMAL(13,2)	NOT NULL		DEFAULT 0
)