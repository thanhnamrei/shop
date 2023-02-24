import { Column } from '@/components/box/Column';
import { Row } from '@/components/box/Row';
import { Button } from '@/components/button/Button';

type PublicLayoutProps = {
  children: React.ReactNode;
};

const View = ({ children }: PublicLayoutProps) => {
  return (
    <div>
      <header>
        <Row gap={6}>
          <span>Trợ giúp</span>
          <span>English</span>|<span>Tiếng Việt</span>
        </Row>
        <Column>
          <span>Trợ giúp</span>
          <span>English</span>|<span>Tiếng Việt</span>
        </Column>
        <Button variant="default">AAAA</Button>
      </header>
      <main>{children}</main>
      <footer></footer>
    </div>
  );
};
export default View;
