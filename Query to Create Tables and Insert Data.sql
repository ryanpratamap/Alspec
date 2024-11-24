CREATE TABLE job (
  id VARCHAR(64) PRIMARY KEY,
  title VARCHAR(1024) NOT NULL,
  description VARCHAR(4096) NOT NULL
)

CREATE TABLE subitem (
  itemid VARCHAR(64) PRIMARY KEY,
  title VARCHAR(1024) NOT NULL,
  description VARCHAR(4096) NOT NULL,
  status VARCHAR(64) NOT NULL,
  jobid VARCHAR(64) NOT NULL
)


INSERT INTO job VALUES ('AL-001', 'Alspec First Job', 'Alspec First Job Description')
INSERT INTO subitem VALUES ('AL-001-S-001', 'Sub Item 1', 'Sub Item 1 Description', 'Pending', 'AL-001')
INSERT INTO subitem VALUES ('AL-001-S-002', 'Sub Item 2', 'Sub Item 2 Description', 'In Progress', 'AL-001')

INSERT INTO job VALUES ('AL-002', 'Alspec Second Job', 'Alspec Second Job Description')
INSERT INTO subitem VALUES ('AL-002-S-001', 'Sub Item 1', 'Sub Item 1 Description', 'Completed', 'AL-002')
INSERT INTO subitem VALUES ('AL-002-S-002', 'Sub Item 2', 'Sub Item 2 Description', 'In Progress', 'AL-002')