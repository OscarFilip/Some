import React, { useState, useEffect } from 'react';
import ReportForm from './Components/ReportForm';
import ReportList from './Components/ReportList';
import './App.css';

const App = () => {
  const [reports, setReports] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetch('https://localhost:7188/api/VehicleReport') //Din https://localhost:
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then(data => {
        setReports(data);
        setLoading(false);
      })
      .catch(error => {
        setError(error);
        setLoading(false);
      });
  }, []);

  const addReport = async (reportData) => {
    try {
      const response = await fetch('https://localhost:7188/api/VehicleReport', { //Din https://localhost:
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(reportData),
      });

      if (!response.ok) {
        throw new Error('Network response was not ok');
      }

      const newReport = await response.json();
      setReports([...reports, newReport]);
    } catch (error) {
      console.error('Error adding report:', error);
    }
  };

  if (loading) return <div>Loading...</div>;
  if (error) return <div>Error: {error.message}</div>;

  return (
    <div className='container'>
      <div className='card'>
        <h1>Felrapportering för fordon</h1>
        <ReportForm addReport={addReport} /> {/* Fix: Pass the correct function */}
        <ReportList reports={reports} />
      </div>
    </div>
  );
};

export default App;