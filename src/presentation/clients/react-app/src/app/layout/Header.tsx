import React from 'react';
import styles from './Header.module.css';

export default function Header() {
  return (
    <div className={styles.container}>
      <span>AzShop</span>
      <input type="text" placeholder="Search" />
      <span>Sign in</span>
    </div>
  );
}
