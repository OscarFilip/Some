import React from 'react';

const ReportList = ({ reports }) => {
  return (
    <div>
      <h2>Tidigare rapporterade fel</h2>
      <ul>
        {reports.map((report, index) => (
          <li key={index}>
            <strong>{report.registrationNumber}</strong>: {report.reportDescripton} (Rapporterat: {report.reportedAt})
          </li>
        ))}
      </ul>
    </div>
  );
};

export default ReportList;