
import React, { useState } from 'react';

const ReportForm = ({ addReport }) => { 
  const [registrationNumber, setRegNumber] = useState('');
  const [reportDescripton, setDescription] = useState('');

  const handleSubmit = async (e) => {
    e.preventDefault();
    console.log(JSON.stringify({ registrationNumber, reportDescripton}));
    try {
      const response = await fetch('https://localhost:7188/api/VehicleReport', { //Din https://localhost:
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ registrationNumber, reportDescripton}),
      });

      if (!response.ok) {
        throw new Error('Failed to add report');
      }

      const newReport = await response.json();
      addReport(newReport); 
      setRegNumber('');
      setDescription('');
    } catch (error) {
      console.error('Error adding report:', error);
    }
  };

  return (
    <form className='ReportForm' onSubmit={handleSubmit}>
      <div>
        <label>Registreringsnummer</label>
        <input
          type="text"
          value={registrationNumber}
          onChange={(e) => setRegNumber(e.target.value)}
          required
        />
      </div>
      <div>
        <label>Beskrivning av felet</label>
        <textarea
          value={reportDescripton}
          onChange={(e) => setDescription(e.target.value)}
          required
        />
      </div>
      <button type="submit">Rapportera</button>
    </form>
  );
};

export default ReportForm;