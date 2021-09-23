import React, { useEffect, useState } from 'react';
import { get } from '../../app/api/agent';
import { TourPackage } from '../../app/models/tour-package/TourPackage';

export default function TourPackagePage() {
  const [loading, setLoading] = useState(false);
  const [tourPackages, setTourPackages] = useState<TourPackage[]>([]);

  useEffect(() => {
    const doGetTourPackage = async () => {
      setLoading(true);
      const result = await get<TourPackage[]>('api/TourPackage');
      setTourPackages(result);
      setLoading(false);
    };
    doGetTourPackage();
  }, []);
  if (loading) return <p>Loading ...</p>;

  return (
    <div>
      {tourPackages?.length &&
        tourPackages.map((tour) => (
          <div key={tour.name}>
            <h3>{tour.name}</h3>
            <h5>{tour.mapLocation}</h5>
            <p>{tour.duration}</p>
            <p>{tour.price}</p>
            <p>{tour.whatToExpect}</p>
            <p>{tour.departureTime}</p>
            <button>View More...</button>
          </div>
        ))}
    </div>
  );
}
