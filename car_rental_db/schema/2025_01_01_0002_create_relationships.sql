USE CovisionDB;

-- Crear relaciones solo si no existen
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_ALQUILER_CLIENTE')
BEGIN
    ALTER TABLE ALQUILER
    ADD CONSTRAINT FK_ALQUILER_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE);
END;

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_ALQUILER_CARRO')
BEGIN
    ALTER TABLE ALQUILER
    ADD CONSTRAINT FK_ALQUILER_CARRO FOREIGN KEY (ID_CARRO) REFERENCES CARRO(ID_CARRO);
END;

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_PAGOS_ALQUILER')
BEGIN
    ALTER TABLE PAGOS
    ADD CONSTRAINT FK_PAGOS_ALQUILER FOREIGN KEY (ID_ALQUILER) REFERENCES ALQUILER(ID_ALQUILER);
END;


